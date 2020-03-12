using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WSR_New_Sewing.Core.Classes;
using WSR_New_Sewing.Core.Entity;
using WSR_New_Sewing.Model;

namespace WSR_New_Sewing.ViewModel
{
    class StockmanViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<StockmanModel> StockmanModels { get; set; }
        public ObservableCollection<Color> Colors { get; set; }
        public ObservableCollection<Material> Materials { get; set; }


        public StockmanViewModel()
        {
            Fill();
        }

        private void Fill()
        {
            try
            {
                using (var ctx = new EntityContext())
                {
                    var colors = ctx.Color.Select(s => s);
                    var materials = ctx.Material.Select(s => s);

                    var stock = from s in ctx.FabricRoll
                                join c in ctx.Color
                                on s.ColorId equals c.Id
                                join mat in ctx.Material
                                on s.MaterialId equals mat.Id
                                select new StockmanModel
                                {
                                    Ид = s.Id,
                                    Материал = mat.Value,
                                    Цвет = c.Value,
                                    Ширина = s.Width,
                                    Длина = s.Length
                                };

                    StockmanModels = new ObservableCollection<StockmanModel>(stock);
                    Colors = new ObservableCollection<Color>(colors);
                    Materials = new ObservableCollection<Material>(materials);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(StockmanModel stockman)
        {
            try
            {
                using (var ctx = new EntityContext())
                {
                    var color_id = ctx.Color.Select(s => s).Where(w => w.Value == stockman.Цвет).FirstOrDefault();
                    var material_id = ctx.Material.Select(s => s).Where(w => w.Value == stockman.Материал).FirstOrDefault();
                    var fabric_id = ctx.FabricRoll.Select(s => s).Where(w => w.Id == stockman.Ид).FirstOrDefault();

                    fabric_id.ColorId = color_id.Id;
                    fabric_id.MaterialId = material_id.Id;
                    fabric_id.Width = stockman.Ширина;
                    fabric_id.Length = stockman.Длина;
                    ctx.SaveChanges();
                    DialogService.ShowSuccess("Даные успешно обновлены!", "Успех!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Add(StockmanModel stockman)
        {
            try
            {
                using (var ctx = new EntityContext())
                {
                    var color_id = ctx.Color.Select(s => s).Where(w => w.Value == stockman.Цвет).FirstOrDefault();
                    var material_id = ctx.Material.Select(s => s).Where(w => w.Value == stockman.Материал).FirstOrDefault();

                    var fab = new FabricRoll
                    {
                        ColorId = color_id.Id,
                        MaterialId = material_id.Id,
                        Width = stockman.Ширина,
                        Length = stockman.Длина
                    };

                    ctx.FabricRoll.Add(fab);
                    ctx.SaveChanges();
                    DialogService.ShowSuccess("Даные успешно добавлены!", "Успех!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(StockmanModel stockman)
        {
            try
            {
                using (var ctx = new EntityContext())
                {
                    var fabric = ctx.FabricRoll.Select(s => s).Where(w => w.Id == stockman.Ид).FirstOrDefault();
                    StockmanModels.Remove(StockmanModels.Select(s => s).Where(w => w.Ид == fabric.Id).FirstOrDefault());
                    ctx.FabricRoll.Remove(fabric);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

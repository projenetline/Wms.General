using Newtonsoft.Json;

namespace Wms.Integration.Entities.JsonObjects
{
    public class CustomJObject
    {
        private static CustomJObject customJObject;
        public static CustomJObject Instance
        {
            get
            {
                if (customJObject != null)
                    return customJObject;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "JsonFile", "Messages.json");
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFile");
                if (!File.Exists(path))
                {
                    customJObject = new CustomJObject();
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    FileStream fs = File.Create(path);
                    fs.Close();
                    File.WriteAllText(path, JsonConvert.SerializeObject(customJObject));
                    return customJObject;
                }
                customJObject = JsonConvert.DeserializeObject<CustomJObject>(path);
                return customJObject;
            }
        }

        private JMessage general;
        private JMessage addressItem;
        private JMessage arp;
        private JMessage warehouse;
        public JMessage WareHouse
        {
            get => warehouse ?? (warehouse = new JMessage
            {
                Get="Depo başarı ile getirildi...",
                NotGet = "Deponuz bulunamadı!",
            });
        }
        public JMessage General
        {
            get => general ?? (general = new JMessage
            {
                Get="Verileriniz getirildi.",
                Create="Verileriniz kaydedildi.",
                Update="Verileriniz güncellendi.",
                GetParameter="Verileriniz istenilen formatta getirildi.",
                Delete="Verileriniz veri tabanınızdan silindi.",
                List="Verileriniz başarılı bir şekilde getirildi.",
                PagedList="Verileriniz başarılı bir şekilde getirildi.",
                Any="Aradığınız veri bulunmaktadır.",

                NotGet = "Veriler getirilemedi!",
                NotCreate = "Verileriniz kaydedilemedi!",
                NotUpdate = "Verileriniz güncellenemedi!",
                NotGetParameter = "Verileriniz istenilen formatta getirilemedi!",
                NotDelete = "Verileriniz veri tabanınızdan silinemedi!",
                NotList = "Verileriniz başarılı bir şekilde getirilemedi!",
                NotPagedList = "Verileriniz başarılı bir şekilde getirilemedi!",
                NotAny ="Aradığınız veri bulunmamaktadır!",
            });
        }
    }
}

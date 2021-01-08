using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using System.IO;
using Xamarin.Forms;
using Lab13.Interfaces;
using Lab13.iOS.Implementations;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab13.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }
    }
}

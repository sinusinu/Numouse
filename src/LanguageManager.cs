// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

using System.Globalization;
using System.Text;

namespace Numouse {
    internal class LanguageManager {
        Dictionary<string, string> dict;
        
        public LanguageManager() {
            dict = new Dictionary<string, string>();

            string langPath = Path.Combine("lang", CultureInfo.InstalledUICulture.Name + ".lang");
            if (!File.Exists(langPath)) {
                langPath = Path.Combine("lang", "default.lang");

                if (!File.Exists(langPath)) {
                    throw new FileNotFoundException("Default language file is missing!");
                }
            }
            
            using (StreamReader sr = new StreamReader(langPath, Encoding.UTF8, false, 512)) {
                string? line;
                while ((line = sr.ReadLine()) != null) {
                    if (line.Contains("=")) {
                        string[] lineSplit = line.Split("=", 2);
                        if (lineSplit.Length == 2) dict.Add(lineSplit[0], lineSplit[1]);
                    }
                }
            }
        }

        public string Get(string key) {
            if (dict.ContainsKey(key)) return dict[key];
            else return key;
        }
    }
}

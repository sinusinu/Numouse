/*
 *  Numouse
 *  Copyright (C) 2021 Woohyun Shin
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

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

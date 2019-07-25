using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Puzzle
{
    class GameSaver_Reader
    {
        public static void saveObject(string objectName, string objectValue, string filePath)
        {
            FileInfo inf = new FileInfo(filePath);
            inf.IsReadOnly = false;
            StreamWriter wr = new StreamWriter(filePath, true);
            wr.WriteLine(objectName + ": " + objectValue);
            wr.Close();
            inf.IsReadOnly = true;
        }

        public static void changeObject(string filePath, string objectName1, string objectValue1, string objectName2, string objectValue2)
        {
            if (File.Exists(filePath) && File.ReadAllText(filePath)!="")
            {
                string line = objectName1 + ": " + objectValue1;
                List<string> l = getListOfFile(filePath);
                FileInfo info = new FileInfo(filePath);
                info.IsReadOnly = false;
                File.Delete(filePath);
                Stream st = File.Create(filePath);
                st.Dispose();
                StreamWriter wd = new StreamWriter(filePath);
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i] == line)
                    {
                        while (l[i].Substring(0, l[i].IndexOf(":")) != objectName2)
                        {
                            wd.WriteLine(l[i]);
                            i++;
                        }
                        l[i] = objectName2 + ": " + objectValue2;
                        wd.WriteLine(l[i]);
                    }
                    else wd.WriteLine(l[i]);
                }
                wd.Close();
                info = new FileInfo(filePath);
                info.IsReadOnly = true;
            }
        }

        public static List<string> getListOfFile(string filePath)
        {
            List<string> l = new List<string>();
            StreamReader rd = new StreamReader(filePath);
            while (!rd.EndOfStream)
                l.Add(rd.ReadLine());
            rd.Close();
            return l;
        }

        public static bool existsObject(string filePath, string objectName, string objectValue)
        {
            if (File.Exists(filePath))
            {
                string line = objectName + ": " + objectValue;
                StreamReader rd = new StreamReader(filePath);
                while (!rd.EndOfStream)
                {
                    if (rd.ReadLine() == line)
                    {
                        rd.Close();
                        return true;
                    }
                }
                rd.Close();
                return false;
            }
            else return false;
        }

        public static string getObjectValue(string filePath, string objectName1, string objectValue, string objectName2)
        {
            if (File.Exists(filePath))
            {
                string line = objectName1 + ": " + objectValue;
                StreamReader rd = new StreamReader(filePath);
                while (!rd.EndOfStream)
                {
                    string line1 = rd.ReadLine();
                    if (line1 == line)
                    {
                        string line2=line1;
                        while (line2.Substring(0, line2.IndexOf(":")) != objectName2)
                        {
                            if (rd.EndOfStream)
                            {
                                rd.Close();
                                return "";
                            }
                            line2 = rd.ReadLine();
                        }
                        rd.Close();
                        return line2.Substring(line2.IndexOf(": ") + 2);
                    }
                }
                rd.Close();
                return "";
            }
            else return "";
        }

        public static string getSavedGame(string GameName)
        {
            createFolder(GameName, DriveInfo.GetDrives()[0].ToString());
            createTextFile("GameInfo", DriveInfo.GetDrives()[0].ToString() + GameName, true);
            return DriveInfo.GetDrives()[0].ToString() +  GameName + "\\GameInfo.txt";
        }

        public static void createFolder(string name, string path)
        {
            Directory.CreateDirectory(path + "\\" + name);
        }

        public static void createTextFile(string name, string path, bool readOnly)
        {
            if (!File.Exists(path + "\\" + name + ".txt"))
            {
                FileStream st = File.Create(path + "\\" + name + ".txt");
                FileInfo info = new FileInfo(path + "\\" + name + ".txt");
                info.IsReadOnly = readOnly;
                st.Dispose();
            }
        }
    }
}

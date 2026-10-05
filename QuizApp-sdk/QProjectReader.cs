using QuizApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QuizApp_sdk
{
    static class QProjectReader
    {
        #region Version
        static private float version = 0;

        static public void SetReaderVersion(float newVer)
        {
            version = newVer;
        }

        static public bool CompareVersions(float ver, bool withMessage = true)
        {
            if(ver > version)
            {
                if (withMessage)
                    MessageBox.Show("QProject is too modern.", "Quiz Application Reader");

                return false;
            }

            return true;
        }

        #endregion
        static public ProjectSettings ReadProject(string proj_filename)
        {
            ProjectSettings settings = new ProjectSettings();

            bool preferencesBlock = false;
            bool pagesBlock = false;
            QuizInfo qI = new QuizInfo();

            using (StreamReader sr = new StreamReader(proj_filename))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();   //new line

                    //Version
                    if(Regex.IsMatch(line, @"^version\s+[0-9.,]{1,}\s*$"))
                    {
                        Regex verex = new Regex(@"^version\s+([0-9.,]{1,})\s*$");
                        Match vermatch = verex.Match(line);
                        string verStr = Regex.Replace(vermatch.Groups[1].Value, @"\.", ",");
                        if(!CompareVersions(float.Parse(verStr)))
                        {
                            return null;
                        }
                    }

                    //BlocksCheckers
                    if(Regex.IsMatch(line, @"^\s*preferences\s*$"))
                    {
                        pagesBlock = false;
                        preferencesBlock = true;
                    }
                    if (Regex.IsMatch(line, @"^\s*pages\s*$"))
                    {
                        preferencesBlock = false;
                        pagesBlock = true;
                    }
                    if (Regex.IsMatch(line, @"^\s*end\s*$"))
                    {
                        break;
                    }

                    //Blocks
                    if(preferencesBlock)
                    {

                    }
                    if (pagesBlock)
                    {
                        if (Regex.IsMatch(line, @"^\s*\d+\s+" + "\"" + @".*?" + "\"" + @"\s+\[0-9-]{1,}\s+" + "\"" + @".*?" + "\"" + @"\s+.*?\s*$"))
                        {
                            settings.QuizList.Add(qI);
                            qI = new QuizInfo();

                            Regex verex = new Regex(@"^\s*(\d+)\s+" + "\"" + @"(.*?)" + "\"" + @"\s+([0-9-]{1,})\s+" + "\"" + @"(.*?)" + "\"" + @"\s+(.*?)\s*$");
                            Match vermatch = verex.Match(line);

                            //Title
                            qI.Title = vermatch.Groups[2].Value;

                            //Next Index
                            if(vermatch.Groups[3].Value == "-")
                            {
                                qI.NextPageIndex = 11223344;
                            }
                            else
                            {
                                qI.NextPageIndex = Int16.Parse(vermatch.Groups[3].Value);
                            }

                            //Image
                            if (vermatch.Groups[4].Value == "NULL" || vermatch.Groups[3].Value == "null")
                            {
                                qI.Image = null;
                            }
                            else
                            {
                                try
                                {
                                    qI.Image = Image.FromFile(vermatch.Groups[3].Value);
                                }
                                catch
                                {
                                    Terminal.SendMessage("Prroblem with image: " + vermatch.Groups[3].Value, MessageType.Error);
                                    Terminal.SendMessage("Image is null", MessageType.Exclamination);
                                    qI.Image = null;
                                }
                            }

                            //Variants
                            if (vermatch.Groups[6].Value == "OneVariant")
                            {
                                qI.Type = QuizType.OneVariant;
                            }
                            else if (vermatch.Groups[6].Value == "FewVariants")
                            {
                                qI.Type = QuizType.FewVariants;
                            }
                            else if (vermatch.Groups[6].Value == "TextVariant")
                            {
                                qI.Type = QuizType.TextVariant;
                            }
                            else if (vermatch.Groups[6].Value == "StartPage")
                            {
                                qI.Type = QuizType.StartPage;
                            }
                            else if (vermatch.Groups[6].Value == "EndPage")
                            {
                                qI.Type = QuizType.EndPage;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else if(Regex.IsMatch(line, @"^var:\s*" + "\"" + @".*?" + "\"" + @"\s*$"))
                        {
                            Regex verex = new Regex(@"^var:\s*" + "\"" + @"(.*?)" + "\"" + @"\s*$");
                            Match vermatch = verex.Match(line);
                            qI.Variants.Add(vermatch.Groups[1].Value);
                        }
                    }
                }
            }

            return settings;
        }
    }
}
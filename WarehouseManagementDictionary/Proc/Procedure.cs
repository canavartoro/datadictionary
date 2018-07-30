using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementDictionary.Proc
{
    public class Procedure
    {
        public List<object> Exec(string args)
        {
            List<object> sonuc = new List<object>();
            try
            {
            }
            catch (Exception exc)
            {
                System.Diagnostics.Trace.WriteLine("Hata oluştu!");
                System.Diagnostics.Trace.WriteLine(exc.Message);
                System.Diagnostics.Trace.WriteLine(exc.StackTrace);
            }
            finally
            {
                sonuc.TrimExcess();
            }
            return sonuc;
        }

        /*
         string code = "";
                                    using (StreamReader reader = new StreamReader(new FileStream(koddosyasi, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.GetEncoding("windows-1254")))
                                    {
                                        code = reader.ReadToEnd().Trim();
                                    }
                                    Object[] requiredAssemblies = new Object[] { };
                                    dynamic classRef;
                                    try
                                    {
                                        classRef = ReflectionHelper.FunctionExec(code, "procedure.proc", requiredAssemblies);

                                        //-------------------
                                        // If the compilation process returned an error, then show to the user all errors
                                        if (classRef is CompilerErrorCollection)
                                        {
                                            StringBuilder sberror = new StringBuilder();

                                            foreach (CompilerError error in (CompilerErrorCollection)classRef)
                                            {
                                                sberror.AppendLine(string.Format("{0}:{1} {2} {3}", error.Line, error.Column, error.ErrorNumber, error.ErrorText));
                                            }

                                            Trace.WriteLine(sberror.ToString());

                                            return;
                                        }

                                        arguman = classRef.Exec(Path.GetFileNameWithoutExtension(f.FullName));
                                    }
                                    catch (Exception ex)
                                    {
                                        // If something very bad happened then throw it
                                        MessageBox.Show(ex.Message);
                                        throw;
                                    }
         */
    }
}

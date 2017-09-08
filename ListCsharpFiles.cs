using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class ListCsharpFiles
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"f:\classroom\inoryasoft");

            var files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            //foreach(FileInfo file in files)
            //{
            //    if ( file.FullName.EndsWith(".cs"))
            //        Console.WriteLine(file.FullName);
            //}

            var csharpFiles =
                from file in files
                where file.Extension == ".cs"
                orderby file.Length
                select new { Name = file.FullName, Length = file.Length };

            //foreach(FileInfo file in csharpFiles)
            //{
            //    Console.WriteLine(file.FullName);
            //}

            //var filesByExt = from file in files
            //                 group file by file.Extension into fileGroup
            //                 orderby fileGroup.Key
            //                 select fileGroup;


            //var filesByExt = from file in files
            //                 group file by file.Extension into fileGroup
            //                 orderby fileGroup.Key
            //                 select new { Extension = fileGroup.Key, Count = fileGroup.Count(f => f.Length > 10000) };


            var filesByExt = files
                             .GroupBy(f => f.Extension)
                             .OrderBy(g => g.Key)
                             .Select(g => new { Extension = g.Key,
                                                Count = g.Count(),
                                                Sum = g.Sum(f=> f.Length) });

                         

            foreach (var v in filesByExt.Where( f => f.Count > 0 ))
            {
                Console.WriteLine("{0} - {1} - {2}", v.Extension, v.Count, v.Sum );
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NFOCreator
{
    public class NFOCreator
    {
        private readonly string _type;
        private readonly string _path;
		
        private DateTime _now;
		
        public NFOCreator(string p, string t) 
        {
            _path = p;
            _type = t;
        }
		
        public int Run() 
        {
            _now = DateTime.Now;
			
            var nfos = DetermineNfOs(_path);
            foreach (var nfo in nfos) 
            {
                //Prepare the variables
                var tokens = nfo.Split('\\');
                tokens = tokens.Last().Substring(0,tokens.Last().Length-4).Replace('_',' ').Split('(');
                var name = tokens[0];
                var year = "";
                if (tokens.Length > 1)
                {
                    year = tokens[1].Split(')')[0];
                }
                
                // write the nfo
                if (_type.Equals("Videos"))
                    CreateNfoVideo(nfo,name,year);
                if (_type.Equals("MusicVideos"))
                    CreateNfoMusicVideos(nfo,name,year);
                if (_type.Equals("TVShows"))
                    CreateNfoMusicVideos(nfo,name,year);
            }

            return nfos.Count;
        }
		
        private static IList<string> DetermineNfOs(string rootPath){
            var response = new List<string>();
            
            // call the function to the subfolders
            foreach (var dir in Directory.EnumerateDirectories(@rootPath))
            {
                response.AddRange(DetermineNfOs(dir));
            }

            var mediaFiles = new List<String>();
            var nfoFiles = new List<String>();

            // discover the files
            foreach (var filename in Directory.EnumerateFiles(rootPath)) {
                if (filename.EndsWith(".nfo")){
                    nfoFiles.Add(filename);
                }
                else if (filename.EndsWith(".iso")||filename.EndsWith(".mkv")||filename.EndsWith(".mp4")||filename.EndsWith(".avi")) {
                    mediaFiles.Add(filename);
                }
            }

            // determine the new nfos that must be created
            foreach (var mediaName in mediaFiles)
            {
                var newName = mediaName.Substring(0,mediaName.Length-3) + "nfo";
                if (!nfoFiles.Contains(newName)){
                    response.Add(newName);
                }
            }

            return response;
        }
		
        private void CreateNfoVideo(string file, string name, string year)
        {
            var sw = new StreamWriter(file)
            {
                AutoFlush = true
            };

            sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
            sw.WriteLine("<movie>");
            sw.WriteLine("\t<title>"+name+"</title>");
            sw.WriteLine("\t<originaltitle>"+name+"</originaltitle>");
            sw.WriteLine("\t<rating>0.000000</rating>");
            sw.WriteLine("\t<epbookmark>0.000000</epbookmark>");
            sw.WriteLine("\t<year>"+year+ "</year>");
            sw.WriteLine("\t<top250>0</top250>");
            sw.WriteLine("\t<outline></outline>");
            sw.WriteLine("\t<plot></plot>");
            sw.WriteLine("\t<tagline></tagline>");
            sw.WriteLine("\t<runtime>60</runtime>");
            sw.WriteLine("\t<mpaa></mpaa>");
            sw.WriteLine("\t<playcount>0</playcount>");
            sw.WriteLine("\t<lastplayed>1601-01-01</lastplayed>");
            sw.WriteLine("\t<status></status>");
            sw.WriteLine("\t<code></code>");            
            sw.WriteLine("\t<aired>1601-01-01</aired>");
            sw.WriteLine("\t<resume>");
            sw.WriteLine("\t\t<position>0.000000</position>");
            sw.WriteLine("\t\t<total>0.000000</total>");
            sw.WriteLine("\t</resume>");
            sw.WriteLine("\t<dateadded>"+_now.ToString("yyyy-MM-dd HH:mm:ss") + "</dateadded>");
            sw.WriteLine("</movie>");
            sw.Close();
        }
		
        private void CreateNfoMusicVideos(string file, string name, string year)
        {
            var sw = new StreamWriter(file)
            {
                AutoFlush = true
            };

            sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
            sw.WriteLine("<musicvideo>");
            sw.WriteLine("\t<title>"+name+"</title>");
            sw.WriteLine("\t<rating>0.000000</rating>");
            sw.WriteLine("\t<epbookmark>0.000000</epbookmark>");
            sw.WriteLine("\t<year>"+year+"</year>");
            sw.WriteLine("\t<top250>0</top250>");
            sw.WriteLine("\t<track>-1</track>");
            sw.WriteLine("\t<album></album>");
            sw.WriteLine("\t<votes></votes>");
            sw.WriteLine("\t<outline></outline>");
            sw.WriteLine("\t<plot></plot>");
            sw.WriteLine("\t<tagline></tagline>");
            sw.WriteLine("\t<runtime>0</runtime>");
            sw.WriteLine("\t<mpaa></mpaa>");
            sw.WriteLine("\t<playcount>0</playcount>");
            sw.WriteLine("\t<lastplayed>1601-01-01</lastplayed>");
            sw.WriteLine("\t<id></id>");
            sw.WriteLine("\t<genre>...</genre>");
            sw.WriteLine("\t<set></set>");
            sw.WriteLine("\t<director></director>");
            sw.WriteLine("\t<premiered>1601-01-01</premiered>");
            sw.WriteLine("\t<status></status>");
            sw.WriteLine("\t<code></code>");
            sw.WriteLine("\t<aired>1601-01-01</aired>");
            sw.WriteLine("\t<studio></studio>");
            sw.WriteLine("\t<trailer></trailer>");
            sw.WriteLine("\t<artist></artist>");
            sw.WriteLine("\t<resume>");
            sw.WriteLine("\t\t<position>0.000000</position>");
            sw.WriteLine("\t\t<total>0.000000</total>");
            sw.WriteLine("\t</resume>");
            sw.WriteLine("\t<dateadded>"+_now.ToString("yyyy-MM-dd HH:mm:ss") + "</dateadded>");
            sw.WriteLine("</musicvideo>");
            sw.Close();
        }
    }
}
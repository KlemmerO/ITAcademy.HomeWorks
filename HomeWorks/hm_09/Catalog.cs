using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class TestItem
    {
        public static void Catalog()
        {
            Film[] myFilms = new Film[3];
            Music[] myMusic = new Music[3];
            ComputerProgram[] myComputerProgram = new ComputerProgram[3];
        }
    }
    public class Item
    {
        protected string name;
        protected string code;
        protected string category;
        protected string size;
        public Item()
        {
        }
        public Item(string name, string code, string category, string size)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.size = size;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
    }
    public class Film : Item
    {
        protected string director;
        protected string mainActor, mainActress;
        public Film()
        {
        }
        public Film(string director, string mainActor, string mainActress)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public string MainActor
        {
            get { return mainActor; }
            set { mainActor = value; }
        }
        public string MainActress
        {
            get { return mainActress; }
            set { mainActress = value; }
        }
        public void Play()
        {
        }
        public void RetrieveInformation()
        {
        }
    }
    public class Music : Item
    {
        protected string singer;
        protected int length;
        public Music()
        {
        }
        public Music(string singer, int length)
        {
            this.singer = singer;
            this.length = length;
        }

        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }
        public int Lenght
        {
            get { return length; }
            set { length = value; }
        }

        public void Play()
        {
        }
        public void RetrieveInformation()
        {
        }
    }
    public class ComputerProgram : Item
    {
    }
}
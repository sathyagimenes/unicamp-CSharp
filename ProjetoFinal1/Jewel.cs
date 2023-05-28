﻿using System;


namespace ProjetoFinal1 {
    public class Jewel : IElement {
        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; }
        public int JewelValue { get; set; }
        public Jewel(int x, int y, string type) {
            X = x;
            Y = y;
            Type = type;
            JewelValue = Type == "JR" ? 100 : Type == "JG" ? 50 : 10;
        }

        public override string ToString()
        {
            if (Type == "JR"){
				Console.BackgroundColor = ConsoleColor.Red;
			}
			else if (Type == "JG"){
				Console.BackgroundColor = ConsoleColor.Green;
			}
            else {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            return (this.Type);
        }
    }
}


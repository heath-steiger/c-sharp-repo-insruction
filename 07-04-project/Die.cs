﻿namespace _07_04_project
{
    public class Die{
        public int Value { get; set; }

        public Die() {
            this.Value = 0;       
        }

        public void Roll(){
           Random r = new Random();
            this.Value = r.Next(1, 7);        
        }
    }
}

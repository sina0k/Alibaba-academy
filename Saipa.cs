using System;
using System.Collections.Generic;
using System.Globalization;
using factory;
namespace sai{
    class Saipa : car{
        
        private int _speed;
        private int _engine;
        private int _className;

        
        public Saipa (int speed,int engine,int className){
            this._speed=speed;
            this._engine= engine;
            this._className =className;
        }
        public int speed{
            get{return _speed;}
            set{_speed = value;}
        }


        public int engine{
            get{return _engine;}
            set{_engine = value;}
        }


        public int className{
            get{return _className;}
            set{_className = value;}
        }

        public void roamRoam(){

        }
        public int ghirpazh(){
            return 10;
        }
    }
}
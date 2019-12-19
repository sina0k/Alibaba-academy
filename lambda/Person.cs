namespace person{

    class Person{
        public int id;
        public string name;
        public string lastName;

        public string address;

        public Person(int id , string name , string lastName,string address){
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.address = address;
        }
    }
}
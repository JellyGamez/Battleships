

namespace Core {

    class Vector2 {

        public int X {get; set;}
        public int Y {get; set;}

        public Vector2(int x, int y) {
            X = x;
            Y = y;
        }
        
        public Vector2() {
            X = 0;
            Y = 0;
        }


        public KeyValuePair<int, int> ToKeyValuePair(){
            return new KeyValuePair<int, int>(X, Y);
        }

        public static Vector2 Random(int maxX, int maxY){
            var random = new Random();
           var  x = random.Next(1, maxX);
           var y = random.Next(1, maxY);
            return new Vector2(x, y);
        }
    }

}
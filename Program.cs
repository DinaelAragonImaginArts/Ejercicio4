
internal class Program
{
    private static void Main(string[] args)
    {
        //Condicionales
        public void condicional(int numeroIf){
            if(numeroIf < 0){
                Console.WriteLine("Este numero es negativo");
            }   else if(numeroIf > 0){
                Console.WriteLine("Este numero es positivo");
            }else if(numeroIf = 0){
                Console.WriteLine("Introduciste un 0");
            }else {
                Console.WriteLine("El valor asignado no corresponde a la petición");
            }
        }
        //While
        public void whileFunction(int numeroWhile){
            while (numeroWhile <= 3)
            {
                int result = numeroWhile ++;
                Console.WriteLine(result); 
            }
        }
        //do While
        public void doWhileFunction(int numeroWhile){
            do
            {
                int result = numeroWhile ++;
                Console.WriteLine(result);
            } while (numeroWhile < 3);
        }
        //For
        public void forFuntion(int numeroFor){
            for(let i = 0; i < numeroFor; i++){
                numeroFor++;
                Console.WriteLine(numeroFor);
            }
        }
        //Switch
        public void switchFunction(string estacion){
            switch (estacion)
            {
                case "Verano":
                    Console.WriteLine(estacion);
                    break;
                case "Otoño":
                    Console.WriteLine(estacion);
                    break;
                case "Primavera":
                    Console.WriteLine(estacion);
                    break;
                case "Invierno":
                    Console.WriteLine(estacion);
                    break;
                default:
                    Console.WriteLine("La Estación mencionada no existe o no se puede reconocer, lo sentimos");
            }
        }
    }
}
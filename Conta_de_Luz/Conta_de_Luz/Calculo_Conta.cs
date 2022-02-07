
namespace Conta_de_Luz
{
    class Calculo_Conta
        //Retorna o Calculo por Kw/H
    {
        public float total;
        public float Calculo(float luz, float kwh)
        {
            total = luz * kwh;
            return total;
        }
    }
   
}


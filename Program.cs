using System;

namespace auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Llanta bridgestone=new Llanta();
            bridgestone.anchoLlantasMilimetros=225;
            bridgestone.altoLlantaMilimetros=50;
            bridgestone.a="R";
            bridgestone.diametroLlantaPulgadas=16; 
            bridgestone.indiceCargaNeumatico=91;
            bridgestone.Muestra(); 

            Motor ford=new Motor();
            ford.cilindrajeMotor=3.5;
            ford.construccionMotor="V";
            ford.numeroCilindros=6;
            ford.Mostrar();

            Volante fanatec=new Volante();
            fanatec.diametroMilimetros=450;
            fanatec.materialVolante="Aluminio";
            fanatec.Imprimir();

            Parachoque SOID4WD=new Parachoque();
            SOID4WD.materialPa="Hierro A36";
            SOID4WD. grosorPa="3mm";
            SOID4WD.Imprimir();

            LimpiaParabrisas bosch=new LimpiaParabrisas();
            bosch.Imprimir();

            
        }
    }
}

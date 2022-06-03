using System;
using System.Xml.Serialization;


namespace Model
{
    /// <summary>
    /// Абстрактный класс РАСЧЁТ КОМПЛЕКСНОГО СОПРОТИВЛЕНИЯ ЭЛЕМЕНТА.
    /// </summary>
    [XmlInclude(typeof(Resistor)), XmlInclude(typeof(Capacitor)), XmlInclude(typeof(Inductor))]
    public abstract class Calc
    {
        /// <summary>
        /// Первый параметр: либо U, либо ω.
        /// </summary>
        private double _Param1;
        /// <summary>
        /// Второй параметр: либо I, либо C, либо L.
        /// </summary>
        private double _Param2; 


        /// <summary>
        /// Сеттер и геттер для Param1.
        /// </summary>
        public double Param1
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,", 
                        Param1), "Param1");

                _Param1 = value;
            }

            get
            {
                return _Param1;
            }
        }


        /// <summary>
        /// Сеттер и геттер для Param2.
        /// </summary>
        public double Param2
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,",
                        Param2), "Param2");

                _Param2 = value;
            }

            get
            {
                return _Param2;
            }
        }

        /// <summary>
        /// Название класса.
        /// </summary>
        /// <returns>Название класса</returns>
        public abstract string Name();


        /// <summary>
        /// Расчёт комплексного сопротивления.
        /// </summary>
        public abstract string Get();
    }
}

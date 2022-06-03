namespace Model
{
    /// <summary>
    /// Класс КОНДЕНСАТОР (Capacitor).
    /// </summary>
    public class Capacitor : Calc
    {        
        /// <summary>
        /// Имя класса.
        /// </summary>
        /// <returns>Имя класса.</returns>
        public override string Name()
        {
            return "Конденсатор (Capacitor)";
        }


        /// <summary>
        /// Расчёт комплексного сопротивления.
        /// </summary>
        /// <returns>Расчёт комплексного сопротивления.</returns>
        public override string Get()
        {
            // Расчёт комплексного сопротивления по формуле -j * 1 / (ω * С) с возвращением результата, где
            //      ω = Param1, Param2 = C.
            return ((-1 / (Param1 * Param2)).ToString() + 'j');
        }
    }
}

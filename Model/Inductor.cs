namespace Model
{
    /// <summary>
    /// Класс ИНДУКТИВНОСТЬ (Inductor).
    /// </summary>
    public class Inductor : Calc
    {
        /// <summary>
        /// Имя класса.
        /// </summary>
        /// <returns>Имя класса.</returns>
        public override string Name()
        {
            return "Индуктивность (Inductor)";
        }


        /// <summary>
        /// Расчёт комплексного сопротивления.
        /// </summary>
        /// <returns>Расчёт комплексного сопротивления.</returns>
        public override string Get()
        {
            // Расчёт комплексного сопротивления по формуле j * ω * L с возвращением результата, где
            //      ω = Param1, L = Param2.
            return ((Param1 * Param2).ToString() + 'j');
        }
    }
}

namespace Model
{
    /// <summary>
    /// Класс РЕЗИСТОР (Resistor).
    /// </summary>
    public class Resistor : Calc
    {
        /// <summary>
        /// Имя класса.
        /// </summary>
        /// <returns>Имя класса.</returns>
        public override string Name()
        {
            return "Резистор (Resistor)";
        }


        /// <summary>
        /// Расчёт комплексного сопротивления.
        /// </summary>
        /// <returns>Расчёт комплексного сопротивления.</returns>
        public override string Get()
        {
            // Расчёт комплексного сопротивления по формуле U / I и возвращение результата, где
            // U = Param1, I = Param2.
            return (Param1 / Param2).ToString();
        }
    }
}

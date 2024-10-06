using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class ConcreteLogReaderCreator : BaseLogReaderCreator
    {
        //фабричный метод
        protected override LogReader CreateLogReaderInstance(LogType logType)
        {
            return logType switch
            {
                LogType.Text => new TextLogReader(),
                LogType.DataBase => new DataBaseLogReader(),
                _ => new LogReader()
            };
        }
    }
}

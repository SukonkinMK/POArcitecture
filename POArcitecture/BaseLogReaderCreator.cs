using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public abstract class BaseLogReaderCreator
    {
        protected abstract LogReader CreateLogReaderInstance(LogType logType);

        protected LogReader CreateLogReader(LogType logType, object data)
        {
            LogReader logReader = CreateLogReaderInstance(logType);
            logReader.DataSorce = data;
            return logReader;
        }
    }
}

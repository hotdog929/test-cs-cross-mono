using System;

namespace eh.core
{
	public interface IWinWorker
	{
		String readWord(String path);
		String writeWord(String content);
	}

	public interface IMacWorker
	{
		String parseXml(String xml);
		String wordCommond(String commond);
	}
}


using System;
using eh.core;

namespace eh.worker
{
	public class MacWorker : IMacWorker
	{
		public String parseXml(String xml){
			return "<parseXml>" + xml;
		}
		public String wordCommond(String commond){
			return "<wordCommond>" + commond;
		}
	}
}

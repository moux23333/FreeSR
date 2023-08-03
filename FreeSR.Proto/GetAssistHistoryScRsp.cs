namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAssistHistoryScRsp
	{
		[ProtoMember(12)] public int FFCBODHLEHF;
		[ProtoMember(7)] public int HMCMJCPFING;
		[ProtoMember(9)] public int ELOIHNNECFM;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(5)] public List<int> JDANNMBGDBC;
	}
	
}

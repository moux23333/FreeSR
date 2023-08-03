namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReportPlayerScRsp
	{
		[ProtoMember(11)] public int Retcode;
	}
	
}

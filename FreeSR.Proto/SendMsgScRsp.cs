namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SendMsgScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(8)] public long EndTime;
	}
	
}

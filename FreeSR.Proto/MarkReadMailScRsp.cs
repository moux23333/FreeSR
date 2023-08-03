namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MarkReadMailScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(10)] public int Id;
	}
	
}

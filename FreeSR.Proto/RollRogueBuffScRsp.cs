namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RollRogueBuffScRsp
	{
		[ProtoMember(15)] public RogueBuffSelectInfo BuffSelectInfo;
		[ProtoMember(11)] public int Retcode;
	}
	
}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SelectRogueBuffScRsp
	{
		[ProtoMember(9)] public int GodPlotId;
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(5)] public RogueBuffSelectInfo BuffSelectInfo;
	}
	
}

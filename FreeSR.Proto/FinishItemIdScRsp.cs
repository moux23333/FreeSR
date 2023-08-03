namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishItemIdScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(11)] public int ItemId;
		[ProtoMember(3)] public int TextId;
	}
	
}

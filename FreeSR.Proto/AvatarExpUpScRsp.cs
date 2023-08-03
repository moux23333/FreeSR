namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarExpUpScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(6)] public List<PileItem> ReturnItemList;
	}
	
}

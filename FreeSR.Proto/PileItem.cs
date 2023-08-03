namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PileItem
	{
		[ProtoMember(5)] public int ItemId;
		[ProtoMember(11)] public int ItemNum;
	}
	
}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PileItem
	{
		[ProtoMember(3)] public int ItemId;
		[ProtoMember(15)] public int ItemNum;
	}

}

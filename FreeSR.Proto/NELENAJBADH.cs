namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NELENAJBADH
	{
		[ProtoMember(13)] public int Level;
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(8)] public ItemList Reward;
	}

}

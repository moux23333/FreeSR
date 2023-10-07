namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ACCJMILCGPF
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(13)] public ItemList Reward;
		[ProtoMember(10)] public int TakeDays;
		[ProtoMember(4)] public int Id;
	}

}

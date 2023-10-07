namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class KONEJEEHLOP
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(9)] public ItemList Reward;
		[ProtoMember(13)] public int Mfmadpcfpen;
	}

}

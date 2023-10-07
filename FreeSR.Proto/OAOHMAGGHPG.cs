namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OAOHMAGGHPG
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(11)] public int Ncmopnnlfee;
		[ProtoMember(10)] public ItemList Reward;
	}

}

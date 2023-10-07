namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LGPICEPNCBE
	{
		[ProtoMember(5)] public ItemList Reward;
		[ProtoMember(10)] public int Retcode;
	}

}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DoGachaCsReq
	{
		[ProtoMember(10)] public int GachaId;
		[ProtoMember(9)] public int GachaRandom;
		[ProtoMember(6)] public int GachaNum;
		[ProtoMember(15)] public int SimulateMagic;
	}

}

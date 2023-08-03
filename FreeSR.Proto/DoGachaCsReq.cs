namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DoGachaCsReq
	{
		[ProtoMember(8)] public int SimulateMagic;
		[ProtoMember(13)] public int GachaNum;
		[ProtoMember(12)] public int GachaRandom;
		[ProtoMember(7)] public int GachaId;
	}
	
}

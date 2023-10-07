namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PCINOANLEKK
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(6)] public HeroBasicType BasicType;
	}

}

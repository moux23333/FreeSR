namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NOFGECHNBBK
	{
		[ProtoMember(2)] public HealthBarInfo CurHealth;
	}

}

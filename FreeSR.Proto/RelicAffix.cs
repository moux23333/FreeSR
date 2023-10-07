namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RelicAffix
	{
		[ProtoMember(1)] public int AffixId;
		[ProtoMember(2)] public int Cnt;
		[ProtoMember(3)] public int Step;
	}

}

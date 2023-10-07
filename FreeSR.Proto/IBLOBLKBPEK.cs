namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class IBLOBLKBPEK
	{
		[ProtoMember(8)] public int Id;
		[ProtoMember(13)] public int TakeDays;
	}

}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MuseumRandomEventSelectCsReq
	{
		[ProtoMember(12)] public int EventId;
		[ProtoMember(13)] public int IGMHELGLILN;
	}
	
}

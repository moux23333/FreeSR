namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MuseumRandomEventSelectScRsp
	{
		[ProtoMember(12)] public int EventId;
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(9)] public int IGMHELGLILN;
	}
	
}

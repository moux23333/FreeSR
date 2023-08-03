namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientDownloadData
	{
		[ProtoMember(1)] public int Version;
		[ProtoMember(2)] public long Time;
		[ProtoMember(3)] public byte[] Data;
	}
	
}

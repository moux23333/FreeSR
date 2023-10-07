namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class VersionCount
	{
		[ProtoMember(1)] public int Version;
		[ProtoMember(2)] public int Count;
	}

}

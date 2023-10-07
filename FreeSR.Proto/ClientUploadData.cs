namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientUploadData
	{
		[ProtoMember(1)] public string Tag;
		[ProtoMember(2)] public string Value;
	}

}

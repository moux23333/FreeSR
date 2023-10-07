namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HMLJDIEDPPA
	{
		[ProtoMember(9)] public int Level;
		[ProtoMember(3)] public int Retcode;
	}

}

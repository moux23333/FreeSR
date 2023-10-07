namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MotionInfo
	{
		[ProtoMember(13)] public Vector Pos;
		[ProtoMember(4)] public Vector Rot;
	}

}

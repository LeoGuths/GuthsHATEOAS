﻿namespace Guths.HATEOAS.Hypermedia.Abstract;

public interface ISupportsHyperMedia
{
    List<HyperMediaLink> Links { get; set; }
}
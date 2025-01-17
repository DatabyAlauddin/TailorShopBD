﻿using System;
using System.Collections.Generic;

namespace TylorShop.Models;

public partial class ModelDifference
{
    public Guid Oid { get; set; }

    public string? UserId { get; set; }

    public string? ContextId { get; set; }

    public int? Version { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<ModelDifferenceAspect> ModelDifferenceAspects { get; set; } = new List<ModelDifferenceAspect>();
}

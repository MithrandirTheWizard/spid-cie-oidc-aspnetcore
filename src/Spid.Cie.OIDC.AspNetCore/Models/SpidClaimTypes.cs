﻿using System;
using System.Collections.Generic;

namespace Spid.Cie.OIDC.AspNetCore.Models;

public sealed class SpidClaimTypes
{
    private static readonly Dictionary<string, SpidClaimTypes> _types = new Dictionary<string, SpidClaimTypes>() {
        { nameof(Name), new SpidClaimTypes(nameof(Name)) },
        { nameof(FamilyName), new SpidClaimTypes(nameof(FamilyName)) },
        { nameof(FiscalNumber), new SpidClaimTypes(nameof(FiscalNumber)) },
        { nameof(Email), new SpidClaimTypes(nameof(Email)) },
        { nameof(DigitalAddress), new SpidClaimTypes(nameof(DigitalAddress)) },
        { nameof(Mail), new SpidClaimTypes(nameof(Mail)) },
        { nameof(Address), new SpidClaimTypes(nameof(Address)) },
        { nameof(CompanyName), new SpidClaimTypes(nameof(CompanyName)) },
        { nameof(CountyOfBirth), new SpidClaimTypes(nameof(CountyOfBirth)) },
        { nameof(DateOfBirth), new SpidClaimTypes(nameof(DateOfBirth)) },
        { nameof(ExpirationDate), new SpidClaimTypes(nameof(ExpirationDate)) },
        { nameof(Gender), new SpidClaimTypes(nameof(Gender)) },
        { nameof(IdCard), new SpidClaimTypes(nameof(IdCard)) },
        { nameof(IvaCode), new SpidClaimTypes(nameof(IvaCode)) },
        { nameof(MobilePhone), new SpidClaimTypes(nameof(MobilePhone)) },
        { nameof(PlaceOfBirth), new SpidClaimTypes(nameof(PlaceOfBirth)) },
        { nameof(RegisteredOffice), new SpidClaimTypes(nameof(RegisteredOffice)) },
        { nameof(SpidCode), new SpidClaimTypes(nameof(SpidCode)) },
        { nameof(CompanyFiscalNumber), new SpidClaimTypes(nameof(CompanyFiscalNumber)) },
        { nameof(DomicileStreetAddress), new SpidClaimTypes(nameof(DomicileStreetAddress)) },
        { nameof(DomicilePostalCode), new SpidClaimTypes(nameof(DomicilePostalCode)) },
        { nameof(DomicileMunicipality), new SpidClaimTypes(nameof(DomicileMunicipality)) },
        { nameof(DomicileProvince), new SpidClaimTypes(nameof(DomicileProvince)) },
        { nameof(DomicileNation), new SpidClaimTypes(nameof(DomicileNation)) }
    };

    private SpidClaimTypes(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static SpidClaimTypes Name { get { return _types[nameof(Name)]; } }
    public static SpidClaimTypes FamilyName { get { return _types[nameof(FamilyName)]; } }
    public static SpidClaimTypes FiscalNumber { get { return _types[nameof(FiscalNumber)]; } }
    public static SpidClaimTypes Email { get { return _types[nameof(Email)]; } }
    public static SpidClaimTypes DigitalAddress { get { return _types[nameof(DigitalAddress)]; } }
    public static SpidClaimTypes Mail { get { return _types[nameof(Mail)]; } }
    public static SpidClaimTypes Address { get { return _types[nameof(Address)]; } }
    public static SpidClaimTypes CompanyName { get { return _types[nameof(CompanyName)]; } }
    public static SpidClaimTypes CountyOfBirth { get { return _types[nameof(CountyOfBirth)]; } }
    public static SpidClaimTypes DateOfBirth { get { return _types[nameof(DateOfBirth)]; } }
    public static SpidClaimTypes ExpirationDate { get { return _types[nameof(ExpirationDate)]; } }
    public static SpidClaimTypes Gender { get { return _types[nameof(Gender)]; } }
    public static SpidClaimTypes IdCard { get { return _types[nameof(IdCard)]; } }
    public static SpidClaimTypes IvaCode { get { return _types[nameof(IvaCode)]; } }
    public static SpidClaimTypes MobilePhone { get { return _types[nameof(MobilePhone)]; } }
    public static SpidClaimTypes PlaceOfBirth { get { return _types[nameof(PlaceOfBirth)]; } }
    public static SpidClaimTypes RegisteredOffice { get { return _types[nameof(RegisteredOffice)]; } }
    public static SpidClaimTypes SpidCode { get { return _types[nameof(SpidCode)]; } }
    public static SpidClaimTypes CompanyFiscalNumber { get { return _types[nameof(CompanyFiscalNumber)]; } }
    public static SpidClaimTypes DomicileStreetAddress { get { return _types[nameof(DomicileStreetAddress)]; } }
    public static SpidClaimTypes DomicilePostalCode { get { return _types[nameof(DomicilePostalCode)]; } }
    public static SpidClaimTypes DomicileMunicipality { get { return _types[nameof(DomicileMunicipality)]; } }
    public static SpidClaimTypes DomicileProvince { get { return _types[nameof(DomicileProvince)]; } }
    public static SpidClaimTypes DomicileNation { get { return _types[nameof(DomicileNation)]; } }

    internal string GetOIDCClaimName()
    {
        return Value switch
        {
            nameof(Name) => SpidConst.name,
            nameof(FamilyName) => SpidConst.familyName,
            nameof(FiscalNumber) => SpidConst.fiscalNumber,
            nameof(Email) => SpidConst.email,
            nameof(DigitalAddress) => SpidConst.digitalAddress,
            nameof(Mail) => SpidConst.mail,
            nameof(Address) => SpidConst.address,
            nameof(CompanyName) => SpidConst.companyName,
            nameof(CountyOfBirth) => SpidConst.countyOfBirth,
            nameof(DateOfBirth) => SpidConst.dateOfBirth,
            nameof(ExpirationDate) => SpidConst.expirationDate,
            nameof(Gender) => SpidConst.gender,
            nameof(IdCard) => SpidConst.idCard,
            nameof(IvaCode) => SpidConst.ivaCode,
            nameof(MobilePhone) => SpidConst.mobilePhone,
            nameof(PlaceOfBirth) => SpidConst.placeOfBirth,
            nameof(RegisteredOffice) => SpidConst.registeredOffice,
            nameof(SpidCode) => SpidConst.spidCode,
            nameof(CompanyFiscalNumber) => SpidConst.companyFiscalNumber,
            nameof(DomicileStreetAddress) => SpidConst.domicileStreetAddress,
            nameof(DomicilePostalCode) => SpidConst.domicilePostalCode,
            nameof(DomicileMunicipality) => SpidConst.domicileMunicipality,
            nameof(DomicileProvince) => SpidConst.domicileProvince,
            nameof(DomicileNation) => SpidConst.domicileNation,
            _ => throw new Exception("Invalid ClaimType"),
        };
    }

}

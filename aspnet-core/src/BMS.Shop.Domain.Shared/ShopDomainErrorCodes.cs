namespace BMS.Shop;

public static class ShopDomainErrorCodes
{
    /* You can add your business exception error codes here, as constants */
    public const string ProductNameAlreadyExists = "Shop:ProductNameAlreadyExists";
    public const string ProductCodeAlreadyExists = "Shop:ProductCodeAlreadyExists";

    public const string ProductSKUAlreadyExists = "Shop:ProductSKUAlreadyExists";
    public const string ProductIsNotExists = "Shop:ProductIsNotExists";
    public const string ProductAttributeIdIsNotExists = "Shop:ProductAttributeIdIsNotExists";

    public const string ProductAttributeValueIsNotValid = "Shop:ProductAttributeValueIsNotValid";

    public const string RoleNameAlreadyExists = "Shop:RoleNameAlreadyExists";
}

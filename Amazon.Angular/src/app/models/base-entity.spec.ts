import { BaseEntity } from './base-entity';

fdescribe('base-entity', () => {
  it('should initialize base-entity', () => {
    const newEntity = new BaseEntity();

    expect(newEntity).toBeDefined();
    expect(newEntity.id).toBe(0);
  });

  it('should initialize base-entity with id parameter', () => {
    const newEntity = new BaseEntity(2);

    expect(newEntity.id).toBe(2);
  });
});

abstract class Formatter {
  protected abstract format(value: any): string
  protected abstract parse(value: string): any

}

export class DateFormatter extends Formatter {
  protected format(value: Date): string {
    return value.toISOString().split('T')[0]
  }

  protected parse(value: string): Date {
    return new Date(value)
  }
}

export class ReceiptFormatter extends Formatter {
  protected format(value: string): string {
    return value.trim()
  }

  protected parse(value: string): string {
    return value.trim()
  }
}